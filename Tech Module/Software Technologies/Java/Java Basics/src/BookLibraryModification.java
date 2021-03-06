import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.Scanner;

public class BookLibraryModification {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.nextLine();

        ArrayList<Book> books = new ArrayList<>();
        Library library = new Library();
        for (int i = 0; i < n; i++) {
            String[] input = scanner.nextLine().split(" ");
            Book book = new Book();
            book.setTitle(input[0]);
            book.setAuthor(input[1]);
            book.setPublisher(input[2]);
            book.setReleaseDate(LocalDate.parse(input[3], DateTimeFormatter.ofPattern("dd.MM.yyyy")));
            book.setIsbn(input[4]);
            book.setPrice(Double.parseDouble(input[5]));
            books.add(book);
        }
        library.setName("My Library");
        library.setBookList(books);
        LocalDate startDate = LocalDate.parse(scanner.nextLine(), DateTimeFormatter.ofPattern("dd.MM.yyyy"));
        Book[] sortedBooks = library.getBookList()
                .stream()
                .filter(a -> a.getReleaseDate().isAfter(startDate))
                .sorted(Comparator.comparing(Book::getReleaseDate).thenComparing(Book::getTitle)).toArray(Book[]::new);

        DateTimeFormatter df = DateTimeFormatter.ofPattern("dd.MM.yyyy");
        for (Book book : sortedBooks){
            System.out.printf("%s -> %s%n", book.getTitle(), df.format(book.getReleaseDate()));
        }
    }

    public static class Book {
        private String title;
        private String author;
        private String publisher;
        private LocalDate releaseDate;
        private String isbn;
        private Double price;

        public Book() {
        }

        public Book(String title, String author, String publisher, LocalDate releaseDate, String isbn, Double price) {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.releaseDate = releaseDate;
            this.isbn = isbn;
            this.price = price;
        }

        public String getTitle() {
            return title;
        }

        public void setTitle(String title) {
            this.title = title;
        }

        public String getAuthor() {
            return author;
        }

        public void setAuthor(String author) {
            this.author = author;
        }

        public String getPublisher() {
            return publisher;
        }

        public void setPublisher(String publisher) {
            this.publisher = publisher;
        }

        public LocalDate getReleaseDate() {
            return releaseDate;
        }

        public void setReleaseDate(LocalDate releaseDate) {
            this.releaseDate = releaseDate;
        }

        public String getIsbn() {
            return isbn;
        }

        public void setIsbn(String isbn) {
            this.isbn = isbn;
        }

        public Double getPrice() {
            return price;
        }

        public void setPrice(Double price) {
            this.price = price;
        }
    }

    public static class Library {
        private String name;
        private ArrayList<Book> bookList;

        public Library() {
        }

        public Library(String name, ArrayList<Book> bookList) {
            this.name = name;
            this.bookList = bookList;
        }

        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public ArrayList<Book> getBookList() {
            return bookList;
        }

        public void setBookList(ArrayList<Book> bookList) {
            this.bookList = bookList;
        }
    }
}