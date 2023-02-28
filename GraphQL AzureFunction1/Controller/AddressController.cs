using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLSPP.Controller
{
    public class AddressController : ControllerBase
    {
        private readonly IAddressTableStorageService _storageService;
        public AddressController(IAddressTableStorageService storageService)
        {
            _storageService = storageService ?? throw new ArgumentNullException(nameof(storageService));
        }
    }
}
