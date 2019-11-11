using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using MustiYazilim.Dal.Interfaces;
using MustiYazilim.OgrenciTaki.Dll.Functions;
using MustiYazilim.OgrenciTaki.Dll.Interfaces;
using MustiYazilim.OgrenciTakip.Common.Enums;
using MustiYazilim.OgrenciTakip.Common.Functions;
using MustiYazilim.OgrenciTakip.Common.Message;
using MustiYazilim.OgrenciTakip.Model.Entities.Base;

namespace MustiYazilim.OgrenciTaki.Dll.Base
{
    public class BaseBll<T, TContext> : IBaseBll where T : BaseEntity where TContext : DbContext
    {
        private readonly Control _ctrl;
        private IUnitOfWork<T> _uow;

        protected BaseBll()
        {

        }
        protected BaseBll(Control ctrl)
        {
            _ctrl = ctrl;
        }

        protected TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFuntions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.rep.Find(filter, selector);
        }

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFuntions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.rep.Select(filter, selector);
        }

        protected bool BaseInsert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            GeneralFuntions.CreateUnitOfWork<T, TContext>(ref _uow);
            //Validation işlemleri yapılacak
            _uow.rep.Insert(entity.EntityConvert<T>());
            return _uow.Save();
        }

        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFuntions.CreateUnitOfWork<T, TContext>(ref _uow);
            //Validation
            var degisenAlanlar = oldEntity.DegisenAlanlariGetir(currentEntity);

            if (degisenAlanlar.Count == 0) return true;
            _uow.rep.Update(currentEntity.EntityConvert<T>(), degisenAlanlar);
            return _uow.Save();
        }

        protected bool BaseDelete(BaseEntity entity, KartTuru kartTuru, bool mesajVer = true)
        {
            GeneralFuntions.CreateUnitOfWork<T, TContext>(ref _uow);
            if (mesajVer)
                if (Messages.SilMesaj(kartTuru.ToName()) != DialogResult.Yes)
                    return false;

            _uow.rep.Delete(entity.EntityConvert<T>());
            return _uow.Save();
        }
        #region Dispose

        public void Dispose()
        {
            _ctrl?.Dispose();
            _uow?.Dispose();
            //GC.SuppressFinalize(this);
        }
        #endregion
    }
}