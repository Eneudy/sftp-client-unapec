import pysftp

hostname = "10.0.0.15"
username = "pi"

local_file = "test-file.txt"
remote_folder = "/home/pi/Desktop/lab07"

with pysftp.Connection(hostname, username) as sftp:
    with sftp.cd(remote_folder):
        sftp.put(local_file)  # upload file
        print("File uploaded!")
