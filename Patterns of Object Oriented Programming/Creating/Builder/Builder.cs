using System;
using System.Text;

class TagBuilder {
    private string _tag = string.Empty;
    private string _content = string.Empty;

    public TagBuilder(string tag, string content) {
        _tag = tag;
        _content = content;
    }

    public TagBuilder(string tag, TagBuilder tagBuilder) {
        _tag = tag;
        _content = tagBuilder.ToString();
    } 

    public override string ToString() {
        string htmlCode = $"<{_tag}>{_content}</{_tag}>";
        return htmlCode;
    }
}

class TagsArrayBuilder {
    private string _tag = string.Empty;
    private string [] _elements;

    public TagsArrayBuilder(string tag, string [] elements) {
        _tag = tag;
        _elements = elements;
    }

    public override string ToString() {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (string s in _elements) {
            string data = new TagBuilder(_tag, s).ToString();
            stringBuilder.Append(data);
        }
        return stringBuilder.ToString();
    }
}

class ProgramMain {
    static void Main() {
        TagBuilder headerMain = new TagBuilder("h1", "Main page");
        TagBuilder boldInfo = new TagBuilder("b", "Here it is description");
        TagBuilder paragraph = new TagBuilder("p", boldInfo);
        TagsArrayBuilder elementsList = new TagsArrayBuilder("li", new string[] { "Maxim", "Nina", "George" });
        TagBuilder ul = new TagBuilder("ul", elementsList.ToString());

        StringBuilder resultBuilder = new StringBuilder();
        resultBuilder.Append(headerMain);
        resultBuilder.Append(paragraph);
        resultBuilder.Append(ul);
        string finalHtml = resultBuilder.ToString();
        Console.WriteLine(finalHtml);
    }
}


