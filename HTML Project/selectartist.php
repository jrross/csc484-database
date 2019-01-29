<HTML>
<HEAD>
<TITLE>Select Artist</TITLE>
</HEAD>

<BODY bgcolor = #ADD8E6>
<H2><CENTER>Display Music Information of a Selected Artist
</CENTER></H2>
<FORM METHOD="post" action="displayartist.php">
<P>
<CENTER>

<?php
/* Connect to MySQL */ 
$link = new mysqli("services1.mcs.sdsmt.edu", "s7275982_f17", "goodol21", "db7275982_f17")or
  die("Unable to connect");

$res = $link->query("select distinct Artist from Music_Album");

$num = mysqli_num_rows($res);

?>

<TABLE>
<TR><TH><strong> Select Artist </strong></TH></TR>
<TR><TD valign = top>
<SELECT size="15" name="selection">
<?php
/* Display each distinct Artist value stored in the database */
for ($i = 0; $i < $num; $i++)
{
   $row=mysqli_fetch_row($res);
   echo "<option> $row[0] </option>";
}
$link->close();
?>

</SELECT></TD>
</TR>
</TABLE>


<P>
<INPUT TYPE="SUBMIT" VALUE="Select">
<INPUT TYPE="RESET"  VALUE="Clear">
<P>
<a href = Music.html>Return to Main Web Page</a>
</CENTER>
</FORM>
</BODY>
<HTML>