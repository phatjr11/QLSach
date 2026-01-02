using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSach.DAL.Models;
using System.Data.Entity.Migrations; // For AddOrUpdate

namespace QLSach.BUS
{
    public class SachService
    {
        private Model1 context;

        public SachService()
        {
            context = new Model1();
        }

        public List<Sach> GetAll()
        {
            return context.Saches.Include("LoaiSach").ToList();
        }

        public List<LoaiSach> GetAllLoaiSach()
        {
            return context.LoaiSaches.ToList();
        }

        public Sach GetById(string id)
        {
            return context.Saches.FirstOrDefault(p => p.MaSach == id);
        }

        public void AddOrUpdate(Sach s)
        {
            context.Saches.AddOrUpdate(s);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var s = context.Saches.FirstOrDefault(p => p.MaSach == id);
            if (s != null)
            {
                context.Saches.Remove(s);
                context.SaveChanges();
            }
        }

        public List<Sach> Search(string keyword)
        {
            return context.Saches.Include("LoaiSach")
                .Where(p => p.MaSach.Contains(keyword) || p.TenSach.Contains(keyword) || p.NamXB.ToString().Contains(keyword))
                .ToList();
        }
    }
}
