﻿namespace GetAnswerApp.DAL.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
