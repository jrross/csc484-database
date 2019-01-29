<HTML>
<HEAD>
<TITLE>Edit Music</TITLE>
</HEAD>

<BODY bgcolor = #ADD8E6>
<H2><CENTER>Edit Music
</CENTER></H2>
<FORM METHOD="post" action="editmusic.php">
<P>
<HR>
<CENTER>

<?php

/* Connect to MySQL */ 
$link = new mysqli("services1.mcs.sdsmt.edu", "s7275982_f17", "goodol21", "db7275982_f17")or
  die("Unable to connect");
  
  if (!isset($_POST['id']))
{
   $id=0;
}
else
{
   $id = $_POST['id'];
}

/* left button*/
if (isset($_POST['left']))
{
   $query = "SELECT ID, Album, ISBN, Artist, Songs, Price 
             FROM Music_ID, Music_Album, Music_ISBN 
			 WHERE Album = mAlbum and ISBN = mISBN and ID < $id 
			 ORDER BY ID DESC";
   $res = $link->query($query);
   $row = mysqli_fetch_row($res);
   if ($row[0] > 0)
   {
       $id       = $row[0];
       $album    = $row[1];
	   $isbn     = $row[2];
	   $artist   = $row[3];
	   $songs    = $row[4];
	   $price    = $row[5];
    }
}
/*right button*/
elseif (isset($_POST['right']))
{
   $query = "SELECT ID, Album, ISBN, Artist, Songs, Price 
             FROM Music_ID, Music_Album, Music_ISBN 
			 WHERE Album = mAlbum and ISBN = mISBN and ID > $id 
			 ORDER BY ID ASC";
   $res = $link->query($query);
   $row = mysqli_fetch_row($res);
   if ($row[0] > 0)
   {
       $id       = $row[0];
       $album    = $row[1];
	   $isbn     = $row[2];
	   $artist   = $row[3];
	   $songs    = $row[4];
	   $price    = $row[5];
    }
}
/*add button*/
elseif (isset($_POST['add']))
{  $album = $_POST['album'];
   $isbn  = $_POST['isbn'];
   $artist= $_POST['artist'];
   $songs = $_POST['songs'];
   $price = $_POST['price'];
   $query = "INSERT INTO Music_ID (ID, Album, ISBN) VALUES('$id','$album','$isbn')";
   $res = $link->query($query);
   $query = "INSERT INTO Music_Album (mAlbum, Artist, Songs) VALUES('$album', '$artist','$songs')";
   $res = $link->query($query);
   $query = "INSERT INTO Music_ISBN (mISBN, Price) VALUES('$isbn', '$price')";
   $res = $link->query($query);
   $message = "Record added";
}
/*delete button*/
elseif (isset($_POST['delete']))
{
   $album = $_POST['album'];
   $isbn = $_POST['isbn'];
   $query = "DELETE FROM Music_Album WHERE mAlbum = '$album'";
   $res = $link->query($query);
   $query = "DELETE FROM Music_ISBN WHERE mISBN = '$isbn'";
   $res = $link->query($query);
   $query = "DELETE FROM Music_ID WHERE ID = '$id'";
   $res = $link->query($query);
   $message = "Record deleted";
}
/*update button*/
elseif (isset($_POST['update']))
{
   $album = $_POST['album'];
   $isbn = $_POST['isbn'];
   $artist = $_POST['artist'];
   $songs = $_POST['songs'];
   $price= $_POST['price'];
   $query = "UPDATE Music_ID, Music_Album, Music_ISBN
             SET Album='$album',mAlbum='$album',ISBN='$isbn',mISBN='$isbn',Artist='$artist',Songs='$songs',Price='$price' 
			 WHERE ID = $id and Album = mAlbum and ISBN = mISBN";
   $res = $link->query($query);
   $message = "Record updated";
}
/*search button*/
elseif (isset($_POST['search']))
{
   $id = $_POST['id'];
   $query = "SELECT ID, Album, ISBN, Artist, Songs, Price
             FROM Music_ID, Music_Album, Music_ISBN
			 WHERE ID LIKE '%$id%' and mAlbum=Album and mISBN=ISBN";
   $res = $link->query($query);
   $row = mysqli_fetch_row($res);
   if ($row[0] > 0)
   {
       $id       = $row[0];
       $album    = $row[1];
	   $isbn     = $row[2];
	   $artist   = $row[3];
	   $songs    = $row[4];
	   $price    = $row[5];
   }
}


$album = trim($album);
$isbn = trim($isbn);
$artist = trim($artist);
$songs = trim($songs);
$price= trim($price);


$link->close();
?>

<BR> Music ID
<BR><INPUT TYPE="TEXT" NAME="id"
    <?php echo "VALUE=\"$id\"" ?>>
<BR>
<BR> ISBN:
<BR><INPUT TYPE="TEXT" NAME="isbn"
    <?php echo "VALUE=\"$isbn\"" ?>>
<BR>
<BR> Price:
<BR><INPUT TYPE="TEXT" NAME="price"
    <?php echo "VALUE=\"$price\"" ?>>
<BR>
<BR> Album:
<BR><INPUT TYPE="TEXT" NAME="album"
    <?php echo "VALUE=\"$album\"" ?>>
<BR>
<BR> Artist:
<BR><INPUT TYPE="TEXT" NAME="artist"
    <?php echo "VALUE=\"$artist\"" ?>>
<BR>
<BR> Songs:
<BR><INPUT TYPE="TEXT" NAME="songs"
    <?php echo "VALUE=\"$songs\"" ?>>
<BR>
<BR>

<INPUT TYPE="SUBMIT" NAME="left"     VALUE="<">
<INPUT TYPE="SUBMIT" NAME="right"    VALUE=">">
<INPUT TYPE="SUBMIT" NAME="search"   VALUE="Search">

<BR>
<BR>
<INPUT TYPE="SUBMIT" NAME="add"      VALUE="Add">
<INPUT TYPE="SUBMIT" NAME="update"   VALUE="Update">
<INPUT TYPE="SUBMIT" NAME="delete"   VALUE="Delete">

<?php
if (isset($_POST['message']))
{
   echo "<BR><BR>$message";
}

?>

<BR>
<BR>
<a href = Music.html>Return to Main Web Page</a>
</CENTER>
</FORM>
</BODY>
<HTML>