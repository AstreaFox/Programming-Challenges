using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedisWrapper;

namespace CSharpWithRedis
{
	static class Program
	{
		static void Main(string[] args)
		{
			var db = new RedisDb("10.0.2.7,password=eRHrHGTTf6vDnvKFkqDV3Mg2NLKhbqM41mMmTIoy");

			db.ValueSet("users", 1000, "hasPony", "yes");
			var v = db.ValueGet("users", 1000, "hasPony");

			db.ListSet("users", 1000, "mice", new string[] { "mouse 1", "mouse 2", "mouse 3" });
			var m = db.ListGet("users", 1000, "mice");
		}
	}
}
