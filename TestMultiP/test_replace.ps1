

$content = [System.IO.File]::ReadAllText("source.txt").Replace("[MY_ID]","Titi").Replace("[HOME_DIR]",$env:UserProfile)
[System.IO.File]::WriteAllText("target.txt", $content)