using System;
using System.Collections.Generic;
using System.Linq;
using StackExchange.Redis;

namespace RedisWrapper
{
	class RedisDb
	{
		public ConnectionMultiplexer Mux { get; }
		public IDatabase Db { get; }


		public void Delete(string database, string key, string field) =>
			Db.KeyDelete($"{database}:{key}:{field}");


		public string ValueGet(string database, string key, string field) =>
			Db.StringGet($"{database}:{key}:{field}").ToString();


		public void ValueSet(string database, string key, string field, string value) =>
			Db.StringSet($"{database}:{key}:{field}", value);


		public string ValueGet(string database, long key, string field) =>
			ValueGet(database, key.ToString(), field);


		public void ValueSet(string database, long key, string field, string value) =>
			ValueSet(database, key.ToString(), field, value);


		public string[] ListGet(string database, string key, string field) =>
			Db.ListRange($"{database}:{key}:{field}").Select(i => i.ToString()).ToArray();


		public void ListSet(string database, string key, string field, string[] list)
		{
			var rKey = $"{database}:{key}:{field}";

			var t = Db.CreateTransaction();
			t.KeyDeleteAsync(rKey);
			t.ListRightPushAsync(rKey, list.Select(i => new RedisValue(i)).ToArray());
			t.Execute();
		}


		public void ListInsertBefore(string database, string key, string field, string item) =>
			Db.ListLeftPush($"{database}:{key}:{field}", item);


		public void ListInsertAfter(string database, string key, string field, string item) =>
			Db.ListRightPush($"{database}:{key}:{field}", item);


		public string ListRemoveFirst(string database, string key, string field) =>
			Db.ListLeftPop($"{database}:{key}:{field}").ToString();


		public string ListRemoveLast(string database, string key, string field) =>
			Db.ListRightPop($"{database}:{key}:{field}").ToString();


		public string[] ListGet(string database, long key, string field) =>
			ListGet(database, key.ToString(), field);


		public void ListSet(string database, long key, string field, string[] list) =>
			ListSet(database, key.ToString(), field, list);


		public void ListInsertBefore(string database, long key, string field, string item) =>
			ListInsertBefore(database, key.ToString(), field, item);


		public void ListInsertAfter(string database, long key, string field, string item) =>
			ListInsertAfter(database, key.ToString(), field, item);


		public string ListRemoveFirst(string database, long key, string field) =>
			ListRemoveFirst(database, key.ToString(), field);


		public string ListRemoveLast(string database, long key, string field) =>
			ListRemoveLast(database, key.ToString(), field);


		public RedisDb(string connectString)
		{
			Mux = ConnectionMultiplexer.Connect(connectString);
			Db = Mux.GetDatabase();
		}
	}
}
