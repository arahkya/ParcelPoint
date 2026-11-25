# ParcelPoint

Blazor WebAssembly app (C# / .NET 11) for parcel intake and tracking.

## Running locally / review on LAN

`scripts/serve-lan.sh` serves the app so it can be browsed from another computer on the LAN:

```bash
./scripts/serve-lan.sh start   # serve on 0.0.0.0:5030 and open a temporary firewall rule
./scripts/serve-lan.sh stop    # stop the server and remove the firewall rule
./scripts/serve-lan.sh clean   # stop + remove SDK, logs, and build output (full undo)
```

- Set `PORT` to serve on a different port (e.g. `PORT=8080 ./scripts/serve-lan.sh start`).
- On first run the script installs the .NET 11 SDK into `/tmp/dotnet11` (ephemeral, requires internet once).
- `start` opens a temporary `ufw` rule for the port; `stop`/`clean` remove it.
- After `start`, browse the printed URL (typically `http://<your-ip>:5030`) from any LAN machine.
- All temporary artifacts live under `/tmp/parcelpoint-*`; the repo's working tree stays clean.
