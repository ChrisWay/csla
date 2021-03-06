﻿//-----------------------------------------------------------------------
// <copyright file="CustomerContactList.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: http://www.lhotka.net/cslanet/
// </copyright>
// <summary>no summary</summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Csla.Security;
using Csla.Core;
using Csla.Serialization;

namespace cslalighttest.CslaDataProvider
{
  [Serializable]
  public class CustomerContactList : BusinessListBase<CustomerContactList, CustomerContact>
  {

    public Customer MyParent
    {
      get { return (Customer)this.Parent; }
    }

#if SILVERLIGHT
    public CustomerContactList() { }
#else
    private CustomerContactList() { }
#endif

#if !SILVERLIGHT
    internal static CustomerContactList GetCustomerContactList(int customerID)
    {
      return DataPortal.FetchChild<CustomerContactList>(customerID);
    }

    private void Child_Fetch(int customerID)
    {
      this.RaiseListChangedEvents = false;
      for (int i = 1; i <= customerID; i++)
      {
        Add(CustomerContact.GetCustomerContact(customerID, i, "First Name # " + i.ToString(), "Last Name # " + i.ToString(), new DateTime(1980 + i, 1, 1)));
      }
      this.RaiseListChangedEvents = true;
    }

#endif

  }
}