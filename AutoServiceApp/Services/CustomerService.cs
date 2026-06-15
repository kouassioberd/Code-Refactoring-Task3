public Customer AddCustomer(ContactInfo info)
{
    var c = new Customer { ContactInfo = info };
    Customers.Add(c);
    SaveAll();
    return c;
}

public void UpdateCustomer(Customer customer, string name, string phone, string email, string address)
{
    customer.Name = name;
    customer.Phone = phone;
    customer.Email = email;
    customer.Address = address;
    foreach (var order in Orders.Where(x => x.CustomerId == customer.Id))
        order.Customer = customer;
    SaveAll();
}

public void DeleteCustomer(Customer customer)
{
    Customers.Remove(customer);
    foreach (var car in Cars.Where(x => x.CustomerId == customer.Id).ToList())
        Cars.Remove(car);
    foreach (var order in Orders.Where(x => x.CustomerId == customer.Id).ToList())
        Orders.Remove(order);
    SaveAll();
}