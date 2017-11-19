using System.Threading.Tasks;
using MongoDB.Driver;

namespace Actio.Common.Mongo {
    public class MongoSeeder : IDatabaseSeeder {
        protected readonly IMongoDatabase Database;

        public MongoSeeder (IMongoDatabase database) {
            this.Database = database;

        }
        public async Task SeedAsync () {
            var collectionCursor = await Database.ListCollectionsAsync();
            var collections = await collectionCursor.ToListAsync();
            if(collections.Count > 0)
                return;
            
            await CustomSeedAsync();

        }

        protected virtual async Task CustomSeedAsync() {
            await Task.CompletedTask;
        }
    }
}