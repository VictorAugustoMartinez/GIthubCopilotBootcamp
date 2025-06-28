using Library.ApplicationCore.Entities;

namespace Library.ApplicationCore;

public interface ILoanRepositoryService
{
    Task<Loan?> GetLoan(int id);
    Task UpdateLoan(Loan loan);
    Task<List<Loan>> GetLoansByBookItemId(int bookItemId);
    Task<List<Loan>> GetLoansByMemberId(int memberId);
}