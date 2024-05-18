namespace Task_4_4._2.ViewModels;

using Task_4_4._2.Models;
using System.Collections.Generic;
using System;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        BlogEntities =
        [
            new BlogEntity {Article = "Заголовок 1", Text = "text 1", TagsList = ["Tag11", "Tag12", "Tag13", "Tag14"], ImagePath="leon.jpg"},
            new BlogEntity {Article = "Заголовок 2", Text = "text 2", TagsList = ["Tag21", "Tag22", "Tag23", "Tag24"], ImagePath= "leon.jpg" }
        ];
        NewsEntities =
        [
            new NewsEntity { Message1 = "Sed hendrerit consectetur tortor, at rutrum nisi posuere et. Curabitur faucibus tincidunt libero ornare vestibulum. Nunc enim dui, aliquet ac sagittis a, rhoncus interdum tellus. Aenean quis varius mauris. Etiam varius imperdiet scelerisque.",
                             Message2 = "Sed tincidunt tincidunt dolor ut congue. Quisque enim nunc, sollicitudin sit amet tincidunt sit amet, congue quis magna.",
                             PublishDate = DateTime.Now},
            new NewsEntity { Message1 = "Sed hendrerit consectetur tortor, at rutrum nisi posuere et. Curabitur faucibus tincidunt libero ornare vestibulum. Nunc enim dui, aliquet ac sagittis a, rhoncus interdum tellus. Aenean quis varius mauris. Etiam varius imperdiet scelerisque.",
                             Message2 = "Sed tincidunt tincidunt dolor ut congue. Quisque enim nunc, sollicitudin sit amet tincidunt sit amet, congue quis magna.",
                             PublishDate = DateTime.Now}
        ];
    }
    public List<BlogEntity> BlogEntities { get; set; }

    public List<NewsEntity> NewsEntities { get; set; }

}