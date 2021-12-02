using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Models;
using App.Models.Branchs;
using BranchModel = App.Models.Branchs.Branch;
namespace App.Repository.IBranch
{
    interface IBranch
    {
        void InsertBranchRecord(BranchModel Branch);
        IEnumerable<BranchModel> GetBranchs();
        void UpdateBranchRecord(BranchModel Branch);
        void DeleteBranchRecord(int id);
        BranchModel GetBranchById(int id);
    }


}