<HTML>
<HEAD>
<TITLE>
Music
</TITLE>
</HEAD>
<BODY bgcolor = #ADD8E6>
<H2>Music for Selected Artist</H2>
<HR height=8>
<P>

<?php
$artist = $_POST['selection'];

/* Connect to MySQL */ 
$link = new mysqli("services1.mcs.sdsmt.edu", "s7275982_f17", "goodol21", "db7275982_f17")or
  die("Unable to connect");

/* Get the valuse from the music tables */
 $result = $link->query("select ID, ISBN, Price, Album, Songs from Music_ID, Music_Album, Music_ISBN 
                        where Album = mAlbum and ISBN = mISBN and Artist = '$artist'");

?>

<TABLE Border="1">
<TR>

<?php
/* Fetch and display the attribute names */
while ($field=mysqli_fetch_field($result))
{
   echo "<TH>";
   echo "$field->name";
   echo "</TH>";
}
echo "</TR>";

/* Fetch and displays each row of $result */ 
if($result)
   while($row=mysqli_fetch_row($result))
   {
      echo "<TR>";
      for ($i=0; $i < mysqli_num_fields($result); $i++)
      {
         echo "<TD> $row[$i] </TD>";
      }
      echo "</TR>\n";
   }

$link->close();
?>

</TABLE>
<BR>
<BR>
<a href = Music.html>Return to Main Web Page</a>
<BR>
<a href = selectartist.php>Select a Different Artist</a>
</BODY>
</HTML>