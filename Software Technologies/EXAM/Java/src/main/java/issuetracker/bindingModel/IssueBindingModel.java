package issuetracker.bindingModel;

public class IssueBindingModel {

    private String title;

    private String content;

    public String getTitle() {
        return title;
    }

    public IssueBindingModel() {
    }

    public IssueBindingModel(String title, String content, Integer priority) {
        this.title = title;
        this.content = content;
        this.priority = priority;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }

    public Integer getPriority() {
        return priority;
    }

    public void setPriority(Integer priority) {
        this.priority = priority;
    }

    private Integer priority;

}
