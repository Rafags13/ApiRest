using System;

namespace ApiRest.Domain.Entities
{
    public class Courses
    {
        public int Id { get; set; }

        public DateTime DataRegister { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }
    }
}