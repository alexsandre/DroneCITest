FROM golang:alpine AS build
WORKDIR /src
COPY ./src .
RUN CGO_ENABLED=0 GOOS=linux GOARCH=amd64 go build -o /out/app

FROM scratch AS bin
COPY --from=build /out/app /
ENTRYPOINT [ "./app" ]
