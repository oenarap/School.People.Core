using Apps.Communication.Contracts;

namespace School.People.Core.Commands
{
    public interface IArchiveOtherPersonCommand : ICommand<IPerson> { }
    public interface IArchivePersonnelCommand : ICommand<IPerson> { }
    public interface IArchiveStudentCommand : ICommand<IPerson> { }
    public interface IUpdateOtherPersonCommand : ICommand<IPerson> { }
    public interface IUpdatePersonnelCommand : ICommand<IPerson> { }
    public interface IUpdateStudentCommand : ICommand<IPerson> { }
    public interface IInsertOtherPersonCommand : ICommand<IPerson> { }
    public interface IInsertPersonnelCommand : ICommand<IPerson> { }
    public interface IInsertStudentCommand : ICommand<IPerson> { }
}