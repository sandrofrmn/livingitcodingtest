using Microsoft.AspNetCore.Mvc;
using BankLibrary;
using BankServer.Interactors;
using System;
using System.Threading.Tasks;
using BankServer.Models;

namespace BankServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : Controller
    {
        private readonly DataAccessDB dataAccess;
        Interactor Interactor = new Interactor();

        [HttpGet]
        public async Task<ActionResult<Transaction>> GetTransactions()
        {
            try
            {
                return Ok(await Interactor.GetTransactions());
            }
            catch (Exception)
            {
                return StatusCode(500, "Couldn't load any transactions.");
            }
        }

        [HttpGet("id")]
        public async Task<ActionResult<Transaction>> GetTransactionsById(int id)
        {
            try
            {
                return Ok(await Interactor.GetTransactionById(id));
            }
            catch (Exception)
            {
                return StatusCode(500, "Transaction doesn't exist.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Transaction>> CreateTransaction(Transaction transaction)
        {
            try
            {
                if (transaction == null)
                {
                    return BadRequest();
                }

                var transactionCreate = await Interactor.WriteTransaction(transaction);

                return CreatedAtAction(nameof(GetTransactionsById),
                    new { id = transactionCreate.TransactionReference }, transactionCreate);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error encountered while creating a new transaction.");
            }
        }
    }
}
