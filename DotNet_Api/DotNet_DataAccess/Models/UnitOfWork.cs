using System;
using DotNet_DataAccess;
using DotNet_DataAccess.Models.Context;
using DotNet_DataAccess.Repository;

namespace Thai_Union_DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        //ITranOefromHeadRepository TranOefromHead { get; }
        //ITranOefromTextRepository TranOefromText { get; }
        //ITranOefromItemContainerRepository TranOefromItemContainer { get; }
        //ITranOefromItemGroupRepository TranOefromItemGroup { get; }
        //ITranOefromItemRepository TranOefromItem { get; }
        //IMasTextMasterRepository MasTextMaster { get; }
        //IMasIncotermLocationRepository MasIncotermLocation { get; }
        //ITranOefromMappingItemGroupRepository TranOefromMappingItemGroup { get; }
        //ITranOefromAttachmentRepository TranOefromAttachment { get; }
        //ITranOefromWfHistoryRepository TranOefromWfHistory { get; }
        IMasEmployeeRepository MasEmployeeRepository { get; }
        int Complete();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DotnetContext _context;
        //private readonly ITranOefromHeadRepository _tranOefromHeadRepository;
        //private readonly ITranOefromTextRepository _tranOefromTextRepository;
        //private readonly ITranOefromItemContainerRepository _tranOefromItemContainerRepository;
        //private readonly ITranOefromItemGroupRepository _tranOefromItemGroupRepository;
        //private readonly ITranOefromItemRepository _tranOefromItemRepository;
        //private readonly IMasTextMasterRepository _masTextMasterRepository;
        //private readonly IMasIncotermLocationRepository _masIncotermLocationRepository;
        //private readonly ITranOefromMappingItemGroupRepository _tranOefromMappingItemGroupRepository;
        public UnitOfWork(DotnetContext context)
        {
            _context = context;
            //TranOefromHead = new TranOefromHeadRepository(_context);
            //TranOefromText = new TranOefromTextRepository(_context);
            //TranOefromItemContainer = new TranOefromItemContainerRepository(_context);
            //TranOefromItemGroup = new TranOefromItemGroupRepository(_context);
            //TranOefromItem = new TranOefromItemRepository(_context);
            //MasTextMaster = new MasTextMasterRepository(_context);
            //MasIncotermLocation = new MasIncotermLocationRepository(_context);
            //TranOefromMappingItemGroup = new TranOefromMappingItemGroupRepository(_context);
            //TranOefromAttachment = new TranOefromAttachmentRepository(_context);
            //TranOefromWfHistory = new TranOefromWfHistoryRepository(_context);
            MasEmployeeRepository = new MasEmployeeRepository(_context);
        }
        //public ITranOefromHeadRepository TranOefromHead { get; private set; }
        //public ITranOefromTextRepository TranOefromText { get; private set; }
        //public ITranOefromItemContainerRepository TranOefromItemContainer { get; private set; }
        //public ITranOefromItemGroupRepository TranOefromItemGroup { get; private set; }
        //public ITranOefromItemRepository TranOefromItem { get; private set; }
        //public IMasTextMasterRepository MasTextMaster { get; private set; }

        //public IMasIncotermLocationRepository MasIncotermLocation { get; private set; }

        //public ITranOefromMappingItemGroupRepository TranOefromMappingItemGroup { get; private set; }

        //public ITranOefromAttachmentRepository TranOefromAttachment { get; private set; }

        //public ITranOefromWfHistoryRepository TranOefromWfHistory { get; private set; }

        public IMasEmployeeRepository MasEmployeeRepository { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
