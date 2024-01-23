
CREATE TABLE PessoaFisica (
    Id INT IDENTITY PRIMARY KEY,
    NomeCompleto NVARCHAR(100),
    DataNascimento DATETIME,
    ValorRenda DECIMAL(18, 2),
    CPF NVARCHAR(11)
);
