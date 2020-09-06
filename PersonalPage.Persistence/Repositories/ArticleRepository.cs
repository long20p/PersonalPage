using PersonalPage.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPage.Persistence.Repositories
{
    public class ArticleRepository : RepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(IDbContext context) : base(context)
        {
            if (!context.DatabaseExists())
            {
                Seed();
            }
        }

        protected override string CollectionName => "articles";

        public void Seed()
        {
            var seeds = new List<Article>
            {
                new Article
                {
                    UniqueId = "ghngfhg-fdsfsd-vvxcb",
                    Title = "Aliquam quis dignissim nibh ut pellentesque consequat vestibulum",
                    Content = @"Donec vulputate luctus laoreet. Vestibulum pulvinar, risus quis aliquam efficitur, urna nisl congue diam, quis condimentum felis lectus sit amet augue. Nam sodales placerat dapibus. Mauris nulla massa, consectetur at blandit quis, aliquam ut mi. Phasellus ac magna a ipsum fringilla malesuada. Cras eu enim in magna tincidunt suscipit. Nullam sit amet velit facilisis, tempor tortor vel, dapibus metus. Praesent dignissim faucibus tortor eu mattis. Morbi lacinia lobortis efficitur. Praesent id tincidunt tellus. Mauris ultricies maximus libero. Donec condimentum eros eros, ut fringilla elit fringilla quis.
Nulla pharetra sagittis nunc, a rutrum nisi mollis at. Nam vitae massa mi. Vestibulum viverra vel quam et scelerisque. Mauris accumsan turpis non odio porttitor, sed pellentesque erat dapibus. Aenean id ipsum nec justo convallis luctus eu id metus. Integer interdum, arcu at rhoncus consectetur, risus dui dignissim diam, et posuere purus dui sed nisl. Aenean metus nulla, vehicula sed nulla sit amet, ornare posuere urna.
Nunc fringilla felis sodales tellus lacinia, eget rutrum sem bibendum. Nam accumsan malesuada magna nec pellentesque. Suspendisse arcu ante, dignissim sed nisi ut, semper sagittis libero. Donec accumsan fermentum rhoncus. Suspendisse est urna, dignissim eu tempor a, fermentum vitae nisl. Ut vel ligula tincidunt, sodales ex id, ornare libero. Sed euismod, dui ac rhoncus facilisis, velit orci porttitor arcu, sit amet fringilla mi diam vel eros. Sed rhoncus, nibh at sagittis dapibus, augue nisi placerat dolor, id vulputate nisi sapien ut odio. Morbi vehicula, mi non sollicitudin egestas, arcu urna molestie leo, quis varius elit ligula sit amet leo.",
                    ContentBrief = "Donec vulputate luctus laoreet. Vestibulum pulvinar, risus quis aliquam efficitur, urna nisl congue diam, quis condimentum felis lectus sit amet augue. Nam sodales placerat dapibus."
                },
                new Article
                {
                    UniqueId = "retreg-bndf-zcfsfss",
                    Title = "Vestibulum ante ipsum primis in faucibus",
                    Content = @"Praesent efficitur consequat risus id mattis. Vivamus suscipit tincidunt molestie. Quisque et bibendum felis, ac posuere tortor. Cras blandit ante ac nisi elementum, gravida molestie magna vehicula. Nam vel auctor sapien. Nunc suscipit massa velit, ut pellentesque nulla ullamcorper vitae. Fusce fermentum nunc quis commodo convallis. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nunc faucibus ex sed sem pretium cursus. Aenean vel ex eget nibh cursus pharetra. Duis accumsan ex sit amet purus lacinia venenatis. Sed quis vestibulum mi. Etiam cursus ultrices pulvinar. Curabitur a laoreet arcu. Vestibulum sed lorem lacus. Morbi interdum ornare nisl vitae tempor.",
                    ContentBrief = "Praesent efficitur consequat risus id mattis. Vivamus suscipit tincidunt molestie. Quisque et bibendum felis, ac posuere tortor"
                },
                new Article
                {
                    UniqueId = "vfsd-vxv-fdsrfseg",
                    Title = "Morbi aliquam nunc nec sodales finibus, nunc mauris massa.",
                    Content = @"Maecenas bibendum a libero nec luctus. Cras tincidunt luctus est nec ultrices. Proin tincidunt est vel scelerisque gravida. Fusce non orci ante. Aliquam erat volutpat. Aenean dapibus, magna in lobortis auctor, sapien metus venenatis ante, ut gravida sem tortor malesuada magna. Ut eget sodales velit, sit amet sollicitudin elit. Integer venenatis viverra lobortis. Curabitur fermentum ante nec nibh volutpat, euismod vehicula quam ultrices. Ut at tortor maximus, pulvinar ante in, convallis ante. Nullam convallis vel lorem at lobortis. Phasellus ut mollis ante. In hendrerit leo ac diam malesuada ornare. Duis consectetur, lectus in posuere sodales, dui nisi gravida sem, fringilla placerat nulla magna eu tortor.
Proin semper purus quis suscipit mollis. Etiam eleifend dolor augue. Proin iaculis finibus sapien. In in elit pellentesque, feugiat ligula sit amet, congue dui. Fusce tempus venenatis nisl in hendrerit. Nunc ornare porttitor sapien non lobortis. Fusce maximus tortor orci, et tristique sapien viverra ut. In dignissim justo et velit venenatis convallis.",
                    ContentBrief = "Maecenas bibendum a libero nec luctus. Cras tincidunt luctus est nec ultrices. Proin tincidunt est vel scelerisque gravida."
                },
                new Article
                {
                    UniqueId = "mnhfggf-ytuyhd-zfdsg",
                    Title = "Mauris blandit ultrices volutpat. Quisque non elit et tellus vehicula tempor eget.",
                    Content = @"Nam lacinia tellus quis commodo dapibus. Phasellus nisi felis, auctor sit amet porttitor nec, placerat sit amet lacus. Integer mattis urna odio, sit amet venenatis arcu efficitur et. Aenean dignissim eleifend urna ut bibendum. Donec vehicula interdum mauris a hendrerit. Vestibulum ultrices euismod sem ac vehicula. Donec quis augue ut elit gravida condimentum at non nibh. In hac habitasse platea dictumst. Integer et ligula eu nibh posuere laoreet. Aenean vehicula purus luctus ullamcorper pharetra. Curabitur pellentesque efficitur vehicula. Vestibulum ullamcorper lacus ut enim accumsan, in porttitor dui commodo. Phasellus fringilla, risus nec lobortis volutpat, tellus nisi consectetur neque, quis pulvinar nulla lorem at leo.",
                    ContentBrief = "Nam lacinia tellus quis commodo dapibus. Phasellus nisi felis, auctor sit amet porttitor nec, placerat sit amet lacus. Integer mattis urna odio"
                },
                new Article
                {
                    UniqueId = "ewrewgfd-vdgdfhd-dfsrs",
                    Title = "Ut eu massa nec mauris porttitor gravida eu ut urna",
                    Content = @"Phasellus sit amet varius nisi. Suspendisse erat orci, euismod sed lorem et, facilisis pretium ipsum. Integer imperdiet metus ut massa tincidunt consectetur. Phasellus vitae massa nec eros lobortis ultricies a a elit. Fusce dapibus, lectus id efficitur interdum, ipsum est posuere lacus, dictum finibus diam turpis efficitur justo. Nam ullamcorper ipsum id nulla efficitur, id semper nunc finibus. Nunc eget dapibus nisl.",
                    ContentBrief = "Phasellus sit amet varius nisi. Suspendisse erat orci, euismod sed lorem et, facilisis pretium ipsum. Integer imperdiet metus ut massa tincidunt consectetur."
                }
            };
            BulkAdd(seeds).Wait();
        }
    }
}
