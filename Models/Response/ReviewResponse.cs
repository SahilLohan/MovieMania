﻿namespace MovieMania.Models.Response
{
    public class ReviewResponse
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int MovieId { get; set; }
        public string UserName { get; set; }
    }
}
