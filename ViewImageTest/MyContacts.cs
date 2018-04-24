using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ViewImageTest
{
    public class MyContacts
    {
        MainActivity mContext;
        public MyContacts(MainActivity context) {
            this.mContext = context;
        }

        public void Start() {
            mContext.insertContact("new Contact");

            mContext.insertContact("new Contact1");

            mContext.insertContact("new Contact2");
        }
    }
}