namespace StringManipulation.Tests.Utilities
{
    public class StringManipulationTests
    {

        [Theory]
        [InlineData(new string[] {
            "abaccadcc", 
            "xyzxy",
        }, new string[] { 
            "ccccaaabd", 
            "xxyyz", })]
        [InlineData(new string[] {
            "dulgvgzwqg",
            "gxtjtmtywr",
            "hnlnxiupgt",
            "gzjotckivp",
            "dpwwsdptae",
            "pcscpilknb",
            "btvyhhmflf",
            "artrtnqxcr",
            "nrtcmcoadn",
            "fkdsgnekft"
        }, new string[] {
            "gggdlquvwz",
            "tttgjmrwxy",
            "nnghilptux",
            "cgijkoptvz",
            "ddppwwaest",
            "ccppbiklns",
            "ffhhblmtvy",
            "rrrttacnqx",
            "ccnnadmort",
            "ffkkdegnst", })]
        [InlineData(new string[] {
            "wzenwebuau",
            "vokfxzynwl",
            "neldfeyrxk",
            "wqadfiodgs",
            "ykiuvzfcbc",
        }, new string[] {
            "eeuuwwabnz",
            "fklnovwxyz",
            "eedfklnrxy",
            "ddafgioqsw",
            "ccbfikuvyz", })]
        [InlineData(new string[] {
            "qakmc",
            "rrtbk",
            "vaixn",
            "wmpnj",
            "uproi",
            "btska",
            "ejqwr",
            "elwlg",
            "oaoiy",
            "hrqkn",
        }, new string[] {
            "ackmq",
            "rrbkt",
            "ainvx",
            "jmnpw",
            "iopru",
            "abkst",
            "ejqrw",
            "llegw",
            "ooaiy",
            "hknqr", })]
        [InlineData(new string[] {
            "pzjim",
            "njnfq",
            "xyohs",
        }, new string[] {
            "ijmpz",
            "nnfjq",
            "hosxy",})]
        [InlineData(new string[] {
           "xqycs",
            "beoax",
            "afkso",
            "bldit",
            "gwrys",
        }, new string[] {
            "cqsxy",
            "abeox",
            "afkos",
            "bdilt",
            "grswy", })]
        public void Input_SortingOperations_ReturnsSortedStrings(string[] strs, string[] expected)
        {
            // Arrange
            var stringManipulation = new StringManipulation.Utilities.StringManipulation();

            // Act
            var actual = stringManipulation.SortingOperations(strs);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
