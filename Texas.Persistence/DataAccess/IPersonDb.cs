﻿namespace Texas.Persistence.DataAccess;

public interface IPersonDb
{
    public Task<IEnumerable<Person>> GetPeopleAsync(string orderby = "id", int limit = 200, int offset = 0);
}
