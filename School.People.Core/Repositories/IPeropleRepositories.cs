using System;
using Apps.DataClient.Core;

namespace School.People.Core.Repositories
{
    public interface IStudentsRepository : IReadAsync<IPerson>, IInsertAsync<IPerson, Guid?>, IUpdateAsync<IPerson>, IReadAllAsync<IPerson>, IArchiveAsync<IPerson> { }
    public interface IPersonnelRepository : IReadAsync<IPerson>, IInsertAsync<IPerson, Guid?>, IUpdateAsync<IPerson>, IReadAllAsync<IPerson>, IArchiveAsync<IPerson> { }
    public interface IOtherPeopleRepository : IReadAsync<IPerson>, IInsertAsync<IPerson, Guid?>, IUpdateAsync<IPerson>, IReadAllAsync<IPerson>, IArchiveAsync<IPerson> { }
    public interface IArchivedPeopleRepository : IReadAllAsync<IPerson> { }
    public interface IActivePeopleRepository : IUpdateAsync<IPerson> { }
    public interface IPersonRepository : IReadAsync<IPerson> { }
}
