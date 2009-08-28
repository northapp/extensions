﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Signum.Entities.Operations;
using Signum.Entities;
using Signum.Entities.Authorization;
using System.Threading;
using Signum.Utilities;
using Signum.Engine.Basics;

namespace Signum.Engine.Operations
{
    public interface IConstructorOperation : IOperation
    {
        IdentifiableEntity Construct(params object[] parameters);
    }

    public class BasicConstructor<T> : IConstructorOperation
        where T: IIdentifiable
    {
        public Enum Key { get; private set; }        
        public Type Type { get { return typeof(T); } }
        public OperationType OperationType { get { return OperationType.Constructor; } }
        public bool Returns { get { return true; } }
        public bool Lazy { get { return false; } }
        public Func<object[], T> Constructor { get; set; }

        public BasicConstructor(Enum key)
        {
            this.Key = key; 
        }

        IdentifiableEntity IConstructorOperation.Construct(params object[] args)
        {
            using (Transaction tr = new Transaction())
            {
                LogOperationDN log = new LogOperationDN
                {
                    Operation = EnumLogic<OperationDN>.ToEntity(Key),
                    Start = DateTime.Now,
                    User = UserDN.Current
                };

                IdentifiableEntity entity = (IdentifiableEntity)(IIdentifiable)OnConstruct(args);

                if (!log.IsNew)
                {
                    log.Target = ((IdentifiableEntity)entity).ToLazy();
                    log.End = DateTime.Now;
                    log.Save();
                }

                return tr.Commit(entity);
            }
        }

        protected virtual T OnConstruct(object[] args)
        {
            return Constructor(args);
        }

        public void AssertIsValid()
        {
            if (Constructor == null)
                throw new ApplicationException("Operation {0} does not have Constructor initialized".Formato(Key));
        }
    }
}
