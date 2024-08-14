namespace Task3ConsoleApp.test
{
    public class UnitTest1
    {
        [Fact]
        public void TraverseFilesystemFromFolder_ShouldReturnFileTree()
        {
            //Arrange
            int expectedStructureLength = 13 * 5 + 39;
            string path = Directory.GetCurrentDirectory();
            FileSystemVisitor visitor = new FileSystemVisitor(path);
            IEnumerable<string> files = new List<string>();
            //Act
            files = visitor.getDirectoryFilesAndFolders();
            //Assert
            Assert.Equal(expectedStructureLength, files.Count());
        }
    }
}