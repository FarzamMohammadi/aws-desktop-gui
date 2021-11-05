﻿using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TheCoolMovieApp.Models;

namespace TheCoolMovieApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult ViewAllMovies()
        {
            GetAllMovieToShow();
            return View();
        }

        private void GetAllMovieToShow()
        {
            SqlConnection conn = new SqlConnection();
            string connString = ClientModel.RDSConnStr;
            conn.ConnectionString = connString;
            conn.Open();
            string newUserQuery = "SELECT * FROM Movies;";
            SqlCommand myCommand = new SqlCommand(newUserQuery, conn);

            var reader = myCommand.ExecuteReader();
            bool userCredsMatch = reader.HasRows;
            List<MovieModel> moviesToShow = new List<MovieModel>();
            while (reader.Read())
            {
                MovieModel movieRecord = new MovieModel();
                movieRecord.Title = reader.GetString(1);
                movieRecord.Year = reader.GetString(2);
                movieRecord.Origin = reader.GetString(3);
                movieRecord.Length = reader.GetString(4);
                moviesToShow.Add(movieRecord);
            };
            MovieModel.MoviesToShow = moviesToShow;
        }

        public IActionResult AddMovie()
        {
            return View();
        }

        public ActionResult RedirectToAddNewMovie()
        {
            return View("AddMovie");
        }

        public ActionResult EditAMovie(MovieModel movie)
        {
            return View("EditMovie", movie);
        }

        //Limit of 2GB also added to web.config
        [HttpPost]
        [RequestFormLimits(MultipartBodyLengthLimit = 2097152000)]
        public ActionResult AddNewMovie(MovieModel newMovie)
        {
            bool uploadSuccess = AddFileToBucket(newMovie.File, newMovie.Title).Result;
            if (uploadSuccess)
            {
                AddNewMovieToDB(newMovie);
            }
            else
            {
                //If upload is Unsuccessful
                MyStringModel UploadUnsuccessful = new MyStringModel();
                UploadUnsuccessful.Message = "Upload Unsuccessful";
                return View("Error", UploadUnsuccessful);
            }
            GetAllMovieToShow();
            return View("ViewAllMovies");
        }

        private void AddNewMovieToDB(MovieModel newMovie)
        {
            //Check to see if table exists, if not, create one
            CreateDBTable();
            //Initialize connection
            SqlConnection conn = new SqlConnection();
            string connString = ClientModel.RDSConnStr;
            conn.ConnectionString = connString;
            conn.Open();

            //Setup query
            string newUserQuery = "INSERT INTO Movies (Title, Year, Origin, Length)";
            newUserQuery += " VALUES (@Title, @Year, @Origin, @Length)";
            SqlCommand myCommand = new SqlCommand(newUserQuery, conn);

            //Setup new movie record details
            myCommand.Parameters.AddWithValue("@Title", newMovie.Title);
            myCommand.Parameters.AddWithValue("@Year", newMovie.Year);
            myCommand.Parameters.AddWithValue("@Origin", newMovie.Origin);
            myCommand.Parameters.AddWithValue("@Length", newMovie.Length);
            myCommand.ExecuteNonQuery();
        }

        private async Task<bool> AddFileToBucket(IFormFile fileToUpload, string title)
        {
            IFormFile file = fileToUpload;
            AmazonS3Client client = ClientModel.S3Client;
            string bucketName = ClientModel.BucketName;
            FileInfo destPath = new FileInfo(file.FileName);
            var fileName = Path.GetFullPath(file.FileName);
            PutObjectRequest request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = title,
            };
            try
            {
                // Put object
                var filePath = Path.GetTempFileName();

                using (var stream = System.IO.File.Create(filePath))
                {
                    await file.CopyToAsync(stream);
                    request.InputStream = stream;
                    PutObjectResponse response = await client.PutObjectAsync(request);
                }
                return true;
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
                return false;
            }
        }

        private void CreateDBTable()
        {
            SqlConnection conn = new SqlConnection();
            string connString = ClientModel.RDSConnStr;
            conn.ConnectionString = connString;
            conn.Open();

            bool exists;

            // check if table exists
            string tableExistQuery = "select case when exists((select * from information_schema.tables where table_name = '" + "Movies" + "')) then 1 else 0 end";
            SqlCommand myCommand = new SqlCommand(tableExistQuery, conn);
            exists = (int)myCommand.ExecuteScalar() == 1;

            //If table does not exist, it gets created
            if (!exists)
            {
                string createTable = "CREATE TABLE Movies (Id int IDENTITY(1,1) PRIMARY KEY, Title varchar(50),Year varchar(4),Origin varchar(30),Length varchar(4));";
                myCommand = new SqlCommand(createTable, conn);
                myCommand.ExecuteNonQuery();
            }
        }
    }
}
