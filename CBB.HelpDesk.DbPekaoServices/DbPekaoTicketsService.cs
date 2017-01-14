﻿using CBB.HelpDesk.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBB.HelpDesk.Models;
using System.Data.Entity;
using CBB.HelpDesk.DbPekaoServices.Properties;

namespace CBB.HelpDesk.DbPekaoServices
{
    public class DbPekaoTicketsService : ITicketsService
    {
        public void Add(Ticket ticket)
        {
            var context = new HelpDeskContext();

            context.Tickets.Add(ticket);

            context.SaveChanges();
        }

        public IList<Ticket> Get()
        {
            var context = new HelpDeskContext();

            var tickets = context.Tickets;

            return tickets.ToList();
        }

        public IList<Ticket> Get(TicketsSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public Ticket Get(int ticketId)
        {
            var context = new HelpDeskContext();


            // Eadger loading
            var ticket = context.Tickets
                .Include(t=> t.Category)
                .Include(t=> t.CreateUser)
                // .Include("Category")
               // .Include(nameof(Category))
                // .Include("CreateUser.Address.City")
                // .Include("CreateUser.Addresses")
                // .Include($"{nameof(Category)}.{nameof(Category.Name)}")
                .Single(t => t.TicketId == ticketId);

            return ticket;
        }

        public void Remove(int ticketId)
        {
            throw new NotImplementedException();
        }

        public void Send(Ticket ticket)
        {
            var context = new HelpDeskContext();

            context.Database.ExecuteSqlCommand(Resources.UpdateGender);
        }

        public void Update(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}