using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SlnErp102.Mvc.ApiService.Stocks.Products;
using SlnErp102.Api.DTOs.Stocks.Product;
using SlnErp102.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using SlnErp102.Mvc.ApiService.Infos.Companies;
using Newtonsoft.Json;

namespace SlnErp102.Mvc.Controllers
{
    public class ProductEntryApiController : Controller
    {
        private readonly ProductEntryApiService _productEntryApiService;
        private readonly CompanyApiService _companyApiService;
        private readonly IMapper _mapper;

        public ProductEntryApiController(ProductEntryApiService productEntryApiService, CompanyApiService companyApiService, IMapper mapper)
        {
            _productEntryApiService = productEntryApiService;
            _companyApiService = companyApiService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var pro = await _productEntryApiService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<ProductEntryDistinctDto>>(pro));
        }

        public async Task<IActionResult> Details(string invoiceNumber)
        {
            var pro = await _productEntryApiService.GetByInvoiceAsync(invoiceNumber);
            return View(_mapper.Map<IEnumerable<ProductEntryDto>>(pro));
        }

        public async Task<IActionResult> Create()
        {
            List<SelectListItem> listCompany= new List<SelectListItem>();
            var CompanyItem = new SelectListItem()
            {
                Value = "",
                Text = "Select Company"
            };
            listCompany.Insert(0, CompanyItem);
            List<SelectListItem> CompanyItemList = (from s in _companyApiService.GetAllAsync().Result
                                                select new SelectListItem()
                                                {
                                                    Text = s.Name,
                                                    Value = s.Id.ToString()
                                                }).ToList();
            listCompany.AddRange(CompanyItemList);
            TempData["Company"] = JsonConvert.SerializeObject(listCompany); //hata burda çözüldü ama neden anlamadım
            ViewBag.Company = listCompany;


            List<SelectListItem> listEntryType = new List<SelectListItem>();
            listEntryType.Insert(0, new SelectListItem()
            {
                Value = "",
                Text = "Select Entry Type"
            });
            var EntryTypeItem = new SelectListItem()
            {
                Value = 1.ToString(),
                Text = "Normal"
            };
            listEntryType.Add(EntryTypeItem);
            EntryTypeItem = new SelectListItem()
            {
                Value = 2.ToString(),
                Text = "Muhtelif"
            };
            listEntryType.Add(EntryTypeItem);
            TempData["EntryType"] = JsonConvert.SerializeObject(listEntryType); //hata burda çözüldü ama neden anlamadım
            ViewBag.EntryType = listEntryType;

            return View();
        }

    }
}
