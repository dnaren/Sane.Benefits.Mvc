using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Sane.Benefits.Mvc.UnitTests.Mocks.InfrastructureData
{
    public class FakeDbSet<T> : IDbSet<T> where T : class
    {
        private readonly ObservableCollection<T> _data;
        private readonly IQueryable _query;

        public FakeDbSet()
        {
            _data = new ObservableCollection<T>();
            _query = _data.AsQueryable();
        }

        public Expression Expression => _query.Expression;
        public Type ElementType => _query.ElementType;
        public IQueryProvider Provider => _query.Provider;
        public ObservableCollection<T> Local => _data;

        public IEnumerator<T> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T Find(params object[] keyValues)
        {
            throw new NotImplementedException("Derivce from FakeDbSet<T> and override with an implementation");
        }

        public T Add(T entity)
        {
            _data.Add(entity);
            return entity;
        }

        public T Remove(T entity)
        {
            _data.Remove(entity);
            return entity;
        }

        public T Attach(T entity)
        {
            _data.Add(entity);
            return entity;
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }
    }
}