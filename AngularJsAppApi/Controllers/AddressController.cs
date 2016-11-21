﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AngularJsAppApi.Models;
using AngularJsAppService;

namespace AngularJsAppApi.Controllers
{
    [RoutePrefix("api/address")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    //[EnableCors(origins: "http://www.example.com", headers: "*", methods: "*")]
    //[EnableCors(origins: "http://localhost:3480/", headers: "*", methods: "*")]
    public class AddressController : ApiController
    {

        private readonly AddessService addessService = new AddessService();

        [HttpGet]
        [Route("getAddressTypes")]
        public IHttpActionResult GetAddressTypes()
        {
            int total = 0;

            ////StudentViewModel studentViewModel = new StudentViewModel();
            ////studentViewModel.Students = studentService.GetStudents(q, pageSize, pageNumber, out total);

            //var studentViewModel = new AddressViewModel{ Students = studentService.Get(q, itemsPerPage, pageNumber, out total) };

            ////ResponseMessage<StudentViewModel> responseMessage = new ResponseMessage<StudentViewModel>();
            ////responseMessage.Result = studentViewModel;

            //var responseMessage = new ResponseMessage<StudentViewModel> { Result = studentViewModel, Total = total };
            //return Ok(responseMessage);
            return Ok();
        }
    }
}