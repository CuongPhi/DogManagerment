﻿using DogManage_HCMC.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogManage_HCMC.DAL
{
    public class AccountConnection
    {
        private static AccountConnection inst;

        public static AccountConnection Inst
        {
            get
            {
                if (inst == null)
                    inst = new AccountConnection();
                return inst;
            }

        }
        private AccountConnection() { }
        public bool isLogin(string userName, string passw)
        {
            string strque = "";
            return DataConnection.Inst.ExcuteQuery(strque).Rows.Count > 0;
        }
        public List<Account> getListAccount()
        {
            List<Account> list = new List<Account>();
            string query = "select * from Account";
            foreach (DataRow item in DataConnection.Inst.ExcuteQuery(query).Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }
            return list;
        }
        public Account getAccountByuserName(string username)
        {
            DataTable account = DataConnection.Inst.ExcuteQuery("Select * from account where userName = '" + username + "'");
            foreach (DataRow item in account.Rows)
            {
                return new Account(item);
            }
            return null;
        }
    }
}
