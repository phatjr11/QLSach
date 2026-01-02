using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSach.DAL.Models;
using System.Data.Entity.Migrations;

namespace QLSach.BUS
{
    public class MuonTraService
    {
        private Model1 context;

        public MuonTraService()
        {
            context = new Model1();
        }

        public List<PhieuMuon> GetAll()
        {
            return context.PhieuMuons.Include("DocGia").Include("Sach").ToList();
        }

        public List<DocGia> GetAllDocGia()
        {
            return context.DocGias.ToList();
        }

        public PhieuMuon GetById(int id)
        {
            return context.PhieuMuons.FirstOrDefault(p => p.MaPM == id);
        }

        public void AddOrUpdate(PhieuMuon pm)
        {
            context.PhieuMuons.AddOrUpdate(pm);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var pm = context.PhieuMuons.FirstOrDefault(p => p.MaPM == id);
            if (pm != null)
            {
                context.PhieuMuons.Remove(pm);
                context.SaveChanges();
            }
        }

        public List<PhieuMuon> Search(string keyword)
        {
            return context.PhieuMuons.Include("DocGia").Include("Sach")
                .Where(p => p.DocGia.TenDG.Contains(keyword) || p.Sach.TenSach.Contains(keyword))
                .ToList();
        }
    }
}
