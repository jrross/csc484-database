<HTML>
<HEAD>
<TITLE>Edit Ratings</TITLE>
</HEAD>

<BODY bgcolor = #ADD8E6>
<H2><CENTER>Edit Ratings
</CENTER></H2>
<FORM METHOD="post" action="editratings.php">
<P>
<HR>
<CENTER>

<?php

/* Connect to MySQL */ 
$link = new mysqli("services1.mcs.sdsmt.edu", "s7275982_f17", "goodol21", "db7275982_f17")or
  die("Unable to connect");
  
  if (!isset($_POST['mid']))
{
   $mid=0;
}
else
{
   $mid = $_POST['mid'];
}

if (isset($_POST['message']))
{
   echo "<BR><BR>$message";
}

/*add button*/
elseif (isset($_POST['add']))
{  $cid = $_POST['cid'];
   $rating = $_POST['rating'];
   $query = "INSERT INTO Norm_Ratings (Music_ID, Customer_ID, Rating) VALUES('$mid','$cid','$rating')";
   $res = $link->query($query);
   $message = "Record added";
}
/*delete button*/
elseif (isset($_POST['delete']))
{
   $query = "DELETE FROM Norm_Ratings WHERE Music_ID = $mid";
   $res = $link->query($query);
   $message = "Record deleted";
}
/*update button*/
elseif (isset($_POST['update']))
{
   $cid = $_POST['cid'];
   $rating = $_POST['rating'];
   $query = "UPDATE Norm_Ratings SET Customer_ID='$cid', Rating='$rating' WHERE Music_ID = $mid";
   $res = $link->query($query);
   $message = "Record updated";
}
/*search button*/
elseif (isset($_POST['search']))
{
   $mid = $_POST['mid'];
   $cid = $_POST['cid'];
   $query = "SELECT Music_ID, Customer_ID, Rating FROM Norm_Ratings WHERE Music_ID = '$mid' AND Customer_ID = '$cid'";
   $res = $link->query($query);
   $row = mysqli_fetch_row($res);
   if ($row[0] > 0)
   {
       $mid     = $row[0];
       $cid     = $row[1];
	   $rating  = $row[2];
   }
}


$cid = trim($cid);
$rating = trim($rating);


$link->close();
?>

<BR> Music ID:
<BR><INPUT TYPE="TEXT" NAME="mid"
    <?php echo "VALUE=\"$mid\"" ?>>
<BR>
<BR> Customer ID:
<BR><INPUT TYPE="TEXT" NAME="cid"
    <?php echo "VALUE=\"$cid\"" ?>>
<BR>
<BR> Rating:
<BR><INPUT TYPE="TEXT" NAME="rating"
    <?php echo "VALUE=\"$rating\"" ?>>
<BR>
<BR>

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
