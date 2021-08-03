using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsole
{
    class Account
    {
        string username;
        Int64 contact;
        string email;
        string address;
        Item[] Kart;
        Item[] orders;
        public void setusername(String username)
        {
            this.username = username;
        }
        public String getusername()
        {
            return username;
        }

        public void setcontact(Int64 contact)
        {
            this.contact = contact;
        }
        public Int64 getcontact()
        {
            return contact;
        }
        public void setemail(String email)
        {
            this.email = email;
        }
        public String getemail()
        {
            return email;
        }
        public void setaddress(String address)
        {
            this.address = address;
        }
        public String getaddress()
        {
            return address;
        }
        public void setKart(Item[] kart)
        {
            this.Kart = kart;
        }
        public Item[] getKart()
        {
            return Kart;
        }
        public void setorders(Item[] orders)
        {
            this.orders = orders;
        }
        public Item[] getorders()
        {
            return orders;
        }
    }
