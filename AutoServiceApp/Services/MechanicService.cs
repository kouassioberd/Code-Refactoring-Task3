public Mechanic AddMechanic(string name, string specialization, decimal hourRate)
{
    var m = new Mechanic { Name = name, Specialization = specialization, HourRate = hourRate };
    Mechanics.Add(m);
    SaveAll();
    return m;
}

public void UpdateMechanic(Mechanic m, string name, string specialization, decimal hourRate)
{
    m.Name = name;
    m.Specialization = specialization;
    m.HourRate = hourRate;
    SaveAll();
}

public void DeleteMechanic(Mechanic m)
{
    Mechanics.Remove(m);
    foreach (var order in Orders.Where(o => o.AssignedMechanicId == m.Id))
    {
        order.AssignedMechanicId = "";
        order.AssignedMechanic = null;
    }
    SaveAll();
}