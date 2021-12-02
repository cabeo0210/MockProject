using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Models;
using App.Models.Branchs;
using Microsoft.EntityFrameworkCore;

namespace App.Repository.IBranchRepository
{
    public class IBranchRepository : App.Repository.IBranch.IBranch
    {
        private readonly AppDbContext _context;
        public IBranchRepository(AppDbContext context)
        {
            _context = context;
        }
        public AppDbContext context { get; set; }
        void IBranch.IBranch.DeleteBranchRecord(int id)
        {
            Branch Branch = _context.Branchs.Find(id);
            _context.Branchs.Remove(Branch);
            _context.SaveChanges();
        }

        Branch IBranch.IBranch.GetBranchById(int id)
        {
            return _context.Branchs.Find(id);
        }

        IEnumerable<Branch> IBranch.IBranch.GetBranchs()
        {
            return _context.Branchs.ToList();
        }

        void IBranch.IBranch.InsertBranchRecord(Branch Branch)
        {
            _context.Branchs.Add(Branch);
            _context.SaveChanges();
        }

        void IBranch.IBranch.UpdateBranchRecord(Branch Branch)
        {
            _context.Entry(Branch).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }


}