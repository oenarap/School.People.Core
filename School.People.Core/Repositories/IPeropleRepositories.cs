using System;
using Apps.DataClient.Contracts;

namespace School.People.Core.Repositories
{
    public interface IStudentsRepository : IPeopleRepository { }
    public interface IPersonnelRepository : IPeopleRepository { }
    public interface IOtherPeopleRepository : IPeopleRepository { }
    public interface IArchivedPeopleRepository : IReadAllAsync<IPerson> { }
    public interface IPeopleRepository : IReadAsync<IPerson>, IInsertAsync<IPerson>, IUpdateAsync<IPerson>, IReadAllAsync<IPerson>, IArchiveAsync<IPerson> { }
}
