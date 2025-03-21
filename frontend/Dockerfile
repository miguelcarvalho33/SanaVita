# Base image
FROM node:20-alpine AS build

# Set working directory
WORKDIR /app

# Copy dependencies file and install
COPY package.json package-lock.json ./
RUN npm install

# Copy the rest of your application
COPY . .

# Build your React application
RUN npm run build

# Use Nginx for serving the static build
FROM nginx:stable-alpine
COPY --from=build /app/dist /usr/share/nginx/html

# Expose port 80
EXPOSE 80

# Start nginx
CMD ["nginx", "-g", "daemon off;"]

