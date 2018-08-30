﻿using System;

namespace Ametista.Query.Queries
{
    public class CardViewQueryModel : IQueryModel
    {
        public string CardHolder { get; set; }

        public DateTime ExpirationDate { get; set; }

        public Guid Id { get; set; }

        public string Number { get; set; }
    }
}