﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerator.Domain
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        //public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}