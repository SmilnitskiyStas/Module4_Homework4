using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateDBByCode.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CreateDBByCode
{
    internal class Starter
    {
        public void Run()
        {
            ApplicationContext appContext = new ApplicationContext();
            appContext.Dispose();
        }
    }
}
