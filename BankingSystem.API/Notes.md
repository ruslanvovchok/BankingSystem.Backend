#### Add new migration
EntityFrameworkCore\add-migration -Name [Migration name] -Context BankingSystemDbContext -OutputDir Persistance/ProposalTool/DbContexts/Migrations -Project ProposalTool.Infrastructure -StartupProject ProposalTool.AdminApi -Verbose

#### Update database
update-database -context BankingSystemDbContext -Project BankingSystem.Infrastructure

#### Update database
EntityFrameworkCore\update-database -context BankingSystemDbContext -Project BankingSystem.Infrastructure

#### Remove last migration
EntityFrameworkCore\remove-migration -context BankingSystemDbContext -Project BankingSystem.Infrastructure