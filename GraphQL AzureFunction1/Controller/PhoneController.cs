using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLSPP.Controller
{
    public class PhoneController : ControllerBase
    {
        private readonly IPhoneTableStorageService _storageService;
        public PhoneController(IPhoneTableStorageService storageService)
        {
            _storageService = storageService ?? throw new ArgumentNullException(nameof(storageService));
        }
    }
}
