﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RASolarHelper.SalesHelperModel
{
    public class CustomerCollectionDetails
    {
        byte __SerialNo = 0;
        DateTime __CollectionDate = DateTime.Now;
        string __RefMemoNo = string.Empty;
        decimal __CollectionAmount = 0;
        string __CollectedByEmployeeID = string.Empty;
        string __CollectedByEmployeeName = string.Empty;

        public byte SerialNo
        {
            set { __SerialNo = value; }
            get { return __SerialNo; }
        }

        public DateTime CollectionDate
        {
            set { __CollectionDate = value; }
            get { return __CollectionDate; }
        }

        public string RefMemoNo
        {
            set { __RefMemoNo = value; }
            get { return __RefMemoNo; }
        }

        public decimal CollectionAmount
        {
            set { __CollectionAmount = value; }
            get { return __CollectionAmount; }
        }

        public string CollectedByEmployeeID
        {
            set { __CollectedByEmployeeID = value; }
            get { return __CollectedByEmployeeID; }
        }

        public string CollectedByEmployeeName
        {
            set { __CollectedByEmployeeName = value; }
            get { return __CollectedByEmployeeName; }
        }

        public CustomerCollectionDetails(byte SrlNo, DateTime CDate, string RefMNo, decimal ColAmnt, string collectedPerson)
        {
            SerialNo = SrlNo;
            CollectionDate = CDate;
            RefMemoNo = RefMNo;
            CollectionAmount = ColAmnt;
            CollectedByEmployeeID = collectedPerson;
            CollectedByEmployeeName = collectedPerson;
        }

        public CustomerCollectionDetails()
        {
        }
    }
}
