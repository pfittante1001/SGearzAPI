select Customers.FirstName, CustAddresses.Address1, CustAddresses.Id
from Customers
inner join CustAddresses
where Customers.Id = CustAddresses.CustomerID