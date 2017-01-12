﻿using CBB.HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBB.HelpDesk.Interfaces
{
    public interface ITicketsService
    {
        Ticket Get(int ticketId);

        void Add(Ticket ticket);

        void Update(Ticket ticket);

        void Remove(int ticketId);

        void Send(Ticket ticket);

    }
}
