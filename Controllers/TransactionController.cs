﻿using Microsoft.AspNetCore.Mvc;
using Boom21.repository;
using Boom21.Domains;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/Transaction")]
    public class TransactionController : ControllerBase
    {
        [HttpPut("Create")]
        public bool Create(Transaction transaction)
        {
            return Storages.TransactionStorage.Create(transaction); ;
        }

        [HttpGet("Read")]
        public Transaction Read(int Id)
        {
            return Storages.TransactionStorage.Read(Id);
        }

        [HttpPut("Update")]
        public Transaction Update(Transaction transaction)
        {
            return Storages.TransactionStorage.Update(transaction);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.TransactionStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.TransactionStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.TransactionStorage.ReadFromXmlFile();
        }
    }
}