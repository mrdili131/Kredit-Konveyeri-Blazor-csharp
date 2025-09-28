using Konveyer.Data;
using Konveyer.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Konveyer.Services{
    public class CreditService{
        private readonly KonveyerDbContext _context;

        public CreditService(KonveyerDbContext context){
            _context = context;
        }

        public async Task<Credit> GetWithId(int id){
            return await _context.Credits.FirstOrDefaultAsync(i=>i.Id==id);
        }

        public async Task Update(Credit credit){
            _context.Credits.Update(credit);
            await _context.SaveChangesAsync();
        }
    }
}