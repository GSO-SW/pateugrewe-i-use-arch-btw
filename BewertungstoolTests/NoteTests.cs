using Bewertungstool;

namespace BewertungstoolTests
{
    [TestClass]
    public class NoteTests
    {
        [TestMethod]
        [DataRow(100, 20, 0.20, 6.00, "6", "ungenügend")]
        [DataRow(100, 26, 0.26, 5.30, "5-", "mangelhaft")]
        [DataRow(100, 33, 0.33, 5.00, "5", "mangelhaft")]
        [DataRow(100, 39, 0.39, 4.70, "5+", "mangelhaft")]
        [DataRow(100, 44, 0.44, 4.30, "4-", "ausreichend")]
        [DataRow(100, 50, 0.50, 4.00, "4", "ausreichend")]
        [DataRow(100, 55, 0.55, 3.70, "4+", "ausreichend")]
        [DataRow(100, 60, 0.60, 3.30, "3-", "befriedigend")]
        [DataRow(100, 65, 0.65, 3.00, "3", "befriedigend")]
        [DataRow(100, 70, 0.70, 2.70, "3+", "befriedigend")]
        [DataRow(100, 75, 0.75, 2.30, "2-", "gut")]
        [DataRow(100, 80, 0.80, 2.00, "2", "gut")]
        [DataRow(100, 85, 0.85, 1.70, "2+", "gut")]
        [DataRow(100, 90, 0.90, 1.30, "1-", "sehr gut")]
        [DataRow(100, 95, 0.95, 1.00, "1", "sehr gut")]
        [DataRow(100, 100, 1.00, 0.70, "1+", "sehr gut")]
        public void Note_Erstellbar(int max_points, int points, double prozent_ergebnis, double dezimal_ergebnis, string kurz_ergebnis, string lang_ergebnis)
        {
            // Arrange
            // Act
            Note n = new Note(max_points, points);

            // Assert
            Assert.AreEqual(max_points, n.MoeglichePunkte);
            Assert.AreEqual(points, n.ErreichtePunkte);
            Assert.AreEqual(prozent_ergebnis, n.Prozent);
            Assert.AreEqual(dezimal_ergebnis, n.Dezimal);
            Assert.AreEqual(kurz_ergebnis, n.Kurz);
            Assert.AreEqual(lang_ergebnis, n.Lang);
        }
    }
}