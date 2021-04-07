using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankingLib;
using Banking.Models;

namespace Banking.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult ShowAllCustomers()
        {
            List<AdminModel> modellist = new List<AdminModel>();
            AdminDAL admDAL = new AdminDAL();
            List<Admin> custlist = admDAL.ShowAllCustomers();

            foreach (var item in custlist)
            {
                AdminModel model = new AdminModel();
                model.Account_No = item.Account_No;
                model.Account_Name = item.Account_Name;
                model.Mobile_No = item.Mobile_No;
                model.Email = item.Email;
                model.Address = item.Address;
                model.Bank_Branch = item.Bank_Branch;
                model.IFSC = item.IFSC;

                modellist.Add(model);
            }

            return View(modellist);
        }

        // GET: Admin/Details/5
        public ActionResult CustomerDetails(long id,Admin adm)
        {          
            AdminDAL adminDAL = new AdminDAL();
            AdminModel model = new AdminModel();
            //Admin adm = new Admin();
            
            adm = adminDAL.ShowCustomerByAccNo(id,adm);

            model.Account_No = adm.Account_No;
            model.Account_Name = adm.Account_Name;
            model.Mobile_No = adm.Mobile_No;
            model.Email = adm.Email;
            model.Address = adm.Address;
            model.Bank_Branch = adm.Bank_Branch;
            model.IFSC = adm.IFSC;

            return View(model);
        }

        
        // GET: Admin/Edit/5
        public ActionResult Edit(long id)
        {
            Admin adm = new Admin();
            AdminModel model = new AdminModel();
            AdminDAL admDAL = new AdminDAL();
            adm = admDAL.ShowCustomerByAccNo(id,adm);
            TempData["id"] = id;
            model.Account_No = adm.Account_No;
            model.Account_Name = adm.Account_Name;
            model.Mobile_No = adm.Mobile_No;
            model.Email = adm.Email;
            model.Address = adm.Address;
            model.Bank_Branch = adm.Bank_Branch;
            model.IFSC = adm.IFSC;

            return View(model);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(Admin model)
        {
           
                // TODO: Add update logic here

                AdminDAL admDAL = new AdminDAL();
                long id = Convert.ToInt64(TempData["id"]);
                admDAL.EditCustomer(id,model);

                return RedirectToAction("ShowAllCustomers");
            
        }

        [HttpGet]
        public ActionResult ShowAllCustomerTranscations()
        {
            List<Transaction> txnList = new List<Transaction>();
            List<TransactionModel> modellist = new List<TransactionModel>();
            AdminDAL admDal = new AdminDAL();

            txnList= admDal.ShowTransactiondetails();

            foreach (var item in txnList)
            {
                TransactionModel model = new TransactionModel();
                model.Sender_Acc = item.Sender_Acc;
                model.Receiver_Acc = item.Receiver_Acc;
                model.Rec_IFSC = item.Rec_IFSC;
                model.Amount = item.Amount;
                model.Transaction_time = item.Transaction_time;
                model.Account_Balance = item.Account_Balance;

                modellist.Add(model);
            }

            return View(modellist);
        }


        public ActionResult ShowCustomerTransaction(long id,Transaction txn)
        {
            TransactionModel model = new TransactionModel();
            AdminDAL admDal = new AdminDAL();
            txn = admDal.ShowTransactionDetailsByAccNo(id);

            model.Sender_Acc = txn.Sender_Acc;
            model.Receiver_Acc = txn.Receiver_Acc;
            model.Rec_IFSC = txn.Rec_IFSC;
            model.Amount = txn.Amount;
            model.Transaction_time = txn.Transaction_time;
            model.Account_Balance = txn.Account_Balance;

            return View(model);
        }

        //// GET: Admin/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Admin/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


        //// GET: Admin/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Admin/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
