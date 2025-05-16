using StockLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace StockLibrary.Repositories


{
    public class ClientRepository
    {
        private readonly AppDbContext _context;
        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        // Ajouter un client
        public void Ajouter(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        // Récupérer un client par ID
        public Client GetById(int id)
        {
            return _context.Clients.Find(id);
        }

        // Récupérer tous les clients
        public List<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        // Mettre à jour un client
        public void Modifier(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }

        // Supprimer un client
        public void Supprimer(int id)
        {
            var client = _context.Clients.Find(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }
    }
}
