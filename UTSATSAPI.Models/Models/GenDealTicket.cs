﻿using System;
using System.Collections.Generic;

namespace UTSATSAPI.Models.Models
{
    public partial class GenDealTicket
    {
        public long Id { get; set; }
        public long? DealId { get; set; }
        public long? TicketId { get; set; }
    }
}